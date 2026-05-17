using System;
using System.Net;
using System.Net.Mail;

namespace ParcelOffice_project
{
    public static class EmailHelper
    {
        // Email Configuration - Update these with your actual credentials
        private const string FROM_EMAIL = "raminisetty.sukhesh@bcah.christuniversity.in";
        private const string EMAIL_PASSWORD = "xryt icyh owtt omkv"; // Replace with actual password or app-specific password
        private const string SMTP_HOST = "smtp.gmail.com";
        private const int SMTP_PORT = 587;
        private const bool ENABLE_SSL = true;

        /// <summary>
        /// Sends a parcel arrival notification email to the student
        /// </summary>
        /// <param name="toEmail">Student's email address</param>
        /// <param name="trackingNumber">Parcel tracking number</param>
        /// <param name="vendorName">Optional courier/vendor name</param>
        public static void SendNotification(string toEmail, string trackingNumber, string vendorName = "")
        {
            try
            {
                // Validate email
                if (string.IsNullOrWhiteSpace(toEmail) || !toEmail.Contains("@"))
                {
                    Console.WriteLine($"[Email] Invalid email address: {toEmail}");
                    return;
                }

                var fromAddress = new MailAddress(FROM_EMAIL, "Parcel Office Management System");
                var toAddress = new MailAddress(toEmail);

                string subject = "Parcel Arrival Notification";
                string htmlBody = GenerateEmailBody(trackingNumber, toEmail, vendorName);

                // Configure SMTP Client
                var smtp = new SmtpClient
                {
                    Host = SMTP_HOST,
                    Port = SMTP_PORT,
                    EnableSsl = ENABLE_SSL,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(FROM_EMAIL, EMAIL_PASSWORD),
                    Timeout = 10000 // 10 seconds timeout
                };

                // Send Email
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = htmlBody,
                    IsBodyHtml = true
                })
                {
                    try
                    {
                        smtp.Send(message);
                        Console.WriteLine($"[✓ Email Sent Successfully] To: {toEmail}, Tracking: {trackingNumber}");
                        System.Windows.Forms.MessageBox.Show(
                            $"Email notification sent to {toEmail}",
                            "Email Sent",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Information);
                    }
                    catch (SmtpException smtpEx)
                    {
                        Console.WriteLine($"[✗ SMTP Error] {smtpEx.Message}");
                        HandleEmailError(smtpEx, toEmail);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[✗ Email Error] {ex.GetType().Name}: {ex.Message}");
                HandleEmailError(ex, toEmail);
            }
        }

        /// <summary>
        /// Generates a formatted HTML email body
        /// </summary>
        private static string GenerateEmailBody(string trackingNumber, string studentEmail, string vendorName)
        {
            string vendorHtml = string.IsNullOrWhiteSpace(vendorName)
                ? string.Empty
                : $"<div style='margin-top:10px;'><span class='tracking-label'>Courier/Vendor:</span> <strong>{vendorName}</strong></div>";

            return $@"
<!DOCTYPE html>
<html>
<head>
    <style>
        body {{ font-family: Arial, sans-serif; line-height: 1.6; color: #333; }}
        .container {{ max-width: 600px; margin: 0 auto; padding: 20px; border: 1px solid #ddd; border-radius: 5px; }}
        .header {{ background-color: #0096641; color: white; padding: 20px; text-align: center; border-radius: 5px 5px 0 0; }}
        .content {{ padding: 20px; }}
        .tracking {{ background-color: #f0f0f0; padding: 15px; border-left: 4px solid #00a651; margin: 20px 0; }}
        .tracking-label {{ font-weight: bold; color: #666; }}
        .tracking-number {{ font-size: 24px; color: #00a651; font-weight: bold; letter-spacing: 2px; }}
        .instructions {{ margin: 20px 0; padding: 15px; background-color: #f9f9f9; border-radius: 5px; }}
        .instructions h3 {{ color: #00a651; margin-top: 0; }}
        .footer {{ text-align: center; font-size: 12px; color: #999; padding-top: 20px; border-top: 1px solid #ddd; margin-top: 20px; }}
        .button {{ background-color: #00a651; color: white; padding: 10px 20px; text-decoration: none; border-radius: 5px; display: inline-block; margin-top: 15px; }}
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>
            <h1>📦 Parcel Arrival Notification</h1>
        </div>

        <div class='content'>
            <p>Dear Student,</p>

            <p>Great news! Your parcel has arrived at the <strong>Parcel Office</strong> and is ready for collection.</p>

            <div class='tracking'>
                <div class='tracking-label'>Tracking Number:</div>
                <div class='tracking-number'>{trackingNumber}</div>
                {vendorHtml}
            </div>

            <div class='instructions'>
                <h3>📋 Collection Instructions:</h3>
                <ul>
                    <li>Visit the <strong>Student Support Office</strong> during working hours</li>
                    <li>Have your <strong>Student ID</strong> ready</li>
                    <li>Quote your <strong>Tracking Number: {trackingNumber}</strong></li>
                    <li>Complete the collection formalities</li>
                </ul>
            </div>

            <div class='instructions'>
                <h3>⏰ Office Hours:</h3>
                <ul>
                    <li>Monday - Friday: 9:00 AM - 5:00 PM</li>
                    <li>Saturday: 10:00 AM - 2:00 PM</li>
                    <li>Sunday & Holidays: Closed</li>
                </ul>
            </div>

            <p>If you have any questions or issues collecting your parcel, please contact the Student Support Office.</p>

            <p>Thank you!</p>
        </div>

        <div class='footer'>
            <p>This is an automated message from Parcel Office Management System</p>
            <p>Please do not reply to this email. Contact Student Support for assistance.</p>
        </div>
    </div>
</body>
</html>";
        }

        /// <summary>
        /// Handles email sending errors with helpful debugging information
        /// </summary>
        private static void HandleEmailError(Exception ex, string toEmail)
        {
            string errorMessage = $"Email sending failed for {toEmail}\n\n";
            errorMessage += $"Error Type: {ex.GetType().Name}\n";
            errorMessage += $"Error Message: {ex.Message}\n\n";

            if (ex is SmtpException smtpEx)
            {
                errorMessage += $"SMTP Status Code: {smtpEx.StatusCode}\n\n";

                switch (smtpEx.StatusCode)
                {
                    case SmtpStatusCode.GeneralFailure:
                        errorMessage += "⚠ General SMTP failure. Check your internet connection and SMTP settings.";
                        break;
                    case SmtpStatusCode.ServiceNotAvailable:
                        errorMessage += "⚠ SMTP service is not available. Try again later.";
                        break;
                    case SmtpStatusCode.MailboxBusy:
                        errorMessage += "⚠ Mailbox is busy. Try sending again in a moment.";
                        break;
                    case SmtpStatusCode.BadCommandSequence:
                        errorMessage += "⚠ Bad command sequence. Check your SMTP configuration.";
                        break;
                    case SmtpStatusCode.ClientNotPermitted:
                        errorMessage += "⚠ Client not permitted. Check your email credentials and permissions.";
                        break;
                    default:
                        errorMessage += "⚠ Troubleshooting steps:\n" +
                                      "1. Check your internet connection\n" +
                                      "2. Verify email credentials are correct\n" +
                                      "3. For Gmail, use an App Password instead of your main password\n" +
                                      "4. Enable 'Less secure app access' if using Gmail";
                        break;
                }
            }

            errorMessage += $"\n\nInner Exception: {ex.InnerException?.Message ?? "None"}";

            Console.WriteLine($"[Email Error Details]\n{errorMessage}");

            // Show user-friendly error message
            System.Windows.Forms.MessageBox.Show(
                $"Could not send email notification to {toEmail}.\n\n" +
                $"Error: {ex.Message}\n\n" +
                $"The parcel has been saved successfully, but the email notification failed.\n" +
                $"Please contact the Student Support Office for assistance.",
                "Email Notification Failed",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Test email functionality - sends a test email to verify configuration
        /// </summary>
        public static bool TestEmailConfiguration(string testEmail)
        {
            try
            {
                Console.WriteLine($"[Testing] Sending test email to: {testEmail}");

                var fromAddress = new MailAddress(FROM_EMAIL, "Parcel Office - Test");
                var toAddress = new MailAddress(testEmail);

                string subject = "Test Email - Parcel Office System";
                string body = "If you received this email, your email configuration is working correctly!";

                var smtp = new SmtpClient
                {
                    Host = SMTP_HOST,
                    Port = SMTP_PORT,
                    EnableSsl = ENABLE_SSL,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(FROM_EMAIL, EMAIL_PASSWORD),
                    Timeout = 10000
                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false
                })
                {
                    smtp.Send(message);
                    Console.WriteLine("[✓ Test Email Sent Successfully]");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[✗ Test Email Failed] {ex.Message}");
                return false;
            }
        }
    }
}