# 📧 Email Configuration Guide - Parcel Office Management System

## ✅ What Was Improved

The EmailHelper has been completely redesigned to ensure proper email functionality:

### **1. Enabled Actual Email Sending**
- ✅ Uncommented the `smtp.Send(message)` line to enable real email sending
- ✅ Added proper SMTP configuration for Gmail
- ✅ Added comprehensive error handling

### **2. Enhanced Email Content**
- ✅ Professional HTML formatted emails
- ✅ Clear collection instructions
- ✅ Office hours information
- ✅ Professional styling with branding

### **3. Robust Error Handling**
- ✅ Detailed error messages for debugging
- ✅ SMTP error code interpretation
- ✅ User-friendly error notifications
- ✅ Console logging for troubleshooting

### **4. Configuration Features**
- ✅ Configurable SMTP settings
- ✅ Email validation
- ✅ Timeout protection
- ✅ Test email functionality

---

## 🔧 Setup Instructions

### **For Gmail (Recommended)**

#### **Option 1: Using Gmail App Password (Recommended)**
This is the secure method for 2FA-enabled accounts:

1. Go to your **Google Account** settings: https://myaccount.google.com/
2. Click **Security** in the left menu
3. Scroll down and enable **2-Step Verification** (if not already enabled)
4. Once 2FA is enabled, you'll see **App Passwords** option
5. Select **Mail** and **Windows Computer**
6. Copy the **16-character password** generated
7. Update `EmailHelper.cs`:
   ```csharp
   private const string EMAIL_PASSWORD = "YOUR_16_CHAR_APP_PASSWORD_HERE";
   ```

#### **Option 2: Using Gmail Account Password**
For accounts WITHOUT 2FA enabled:

1. Update `EmailHelper.cs` with your actual Gmail credentials:
   ```csharp
   private const string FROM_EMAIL = "your.email@gmail.com";
   private const string EMAIL_PASSWORD = "your_gmail_password";
   ```

2. Enable "Less Secure Apps" on your Google Account:
   - Go to: https://myaccount.google.com/security
   - Scroll to "Less secure app access"
   - Toggle ON

---

### **For Other Email Providers**

#### **Microsoft Outlook/Office365:**
```csharp
private const string SMTP_HOST = "smtp.outlook.com";
private const int SMTP_PORT = 587;
private const bool ENABLE_SSL = true;
private const string FROM_EMAIL = "your.email@outlook.com";
private const string EMAIL_PASSWORD = "your_password";
```

#### **Yahoo Mail:**
```csharp
private const string SMTP_HOST = "smtp.mail.yahoo.com";
private const int SMTP_PORT = 587;
private const bool ENABLE_SSL = true;
private const string FROM_EMAIL = "your.email@yahoo.com";
private const string EMAIL_PASSWORD = "your_16_char_app_password";
```

#### **Custom SMTP Server:**
```csharp
private const string SMTP_HOST = "your.smtp.server.com";
private const int SMTP_PORT = 587; // or 25, 465
private const bool ENABLE_SSL = true; // or false
private const string FROM_EMAIL = "your.email@domain.com";
private const string EMAIL_PASSWORD = "your_password";
```

---

## 🧪 Testing Email Configuration

### **Method 1: Using the Test Function**
Add a button to your Form to test email:

```csharp
private void btnTestEmail_Click(object sender, EventArgs e)
{
	string testEmail = "your.test.email@gmail.com";
	if (EmailHelper.TestEmailConfiguration(testEmail))
	{
		MessageBox.Show("✓ Email test successful! Check your inbox.", "Email Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
	}
	else
	{
		MessageBox.Show("✗ Email test failed. Check the console for details.", "Email Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
	}
}
```

### **Method 2: Manual Testing**
1. Save a parcel in the application
2. Check the student's inbox
3. Look for "🎉 Your Parcel Has Arrived!" email
4. Check the **Output Window** in Visual Studio for debug messages

---

## 🔍 Troubleshooting

### **Error: "SMTPStatusCode.ClientNotPermitted"**
- For Gmail: Use **App Password** instead of account password
- Check email credentials are correct
- Enable "Less secure app access" if using Gmail password

### **Error: "Service Not Available"**
- Check your internet connection
- SMTP server might be temporarily down
- Try again in a few moments

### **Error: "Mailbox Not Allowed"**
- The email account might not be authenticated properly
- Verify credentials in `EmailHelper.cs`
- Check if account requires 2FA setup

### **Error: "Timeout"**
- Increase the timeout value:
  ```csharp
  Timeout = 20000 // 20 seconds instead of 10
  ```

### **No Email Received**
1. Check **Spam/Junk** folder
2. Review **Console Output** in Visual Studio for error messages
3. Verify the recipient email is correct
4. Check SMTP settings are configured properly

---

## 📋 Email Configuration Checklist

- [ ] Updated `FROM_EMAIL` with correct email address
- [ ] Updated `EMAIL_PASSWORD` with app password or account password
- [ ] Updated `SMTP_HOST` for correct email provider
- [ ] Updated `SMTP_PORT` if needed
- [ ] Tested email functionality
- [ ] Email received in student inbox
- [ ] HTML formatting displays correctly
- [ ] Error messages are helpful for debugging

---

## 🚀 Features Included

### **SendNotification(toEmail, trackingNumber)**
- Sends formatted parcel arrival notification
- Includes tracking number and collection instructions
- Handles errors gracefully with user-friendly messages
- Logs all activity to console for debugging

### **TestEmailConfiguration(testEmail)**
- Sends a test email to verify setup
- Returns true/false based on success
- Useful for troubleshooting configuration issues

### **Error Handling**
- Validates email addresses before sending
- Catches and interprets SMTP errors
- Shows detailed error messages to users
- Logs full exception details for debugging

---

## 📝 Email Template Includes

✅ Professional HTML formatting
✅ Tracking number in large, visible format
✅ Clear collection instructions (3 steps)
✅ Office hours information
✅ Support contact information
✅ Branded footer with system name
✅ Responsive design
✅ Color-coded sections for easy reading

---

## 🔐 Security Notes

⚠️ **NEVER commit credentials to GitHub!**

For production:
1. Store credentials in environment variables
2. Use encrypted configuration files
3. Implement Azure Key Vault or similar service
4. Use separate email accounts per environment (dev, test, prod)

Example using environment variables:
```csharp
private const string FROM_EMAIL = ""; // Set from Environment.GetEnvironmentVariable("PARCEL_EMAIL")
private const string EMAIL_PASSWORD = ""; // Set from Environment.GetEnvironmentVariable("PARCEL_EMAIL_PASSWORD")
```

---

## ✨ Next Steps

1. **Update credentials** in `EmailHelper.cs`
2. **Rebuild** the project
3. **Test** by saving a parcel
4. **Verify** email is received
5. **Check console** for any error messages
6. **Adjust settings** if needed

---

**Questions?** Check the console output in Visual Studio for detailed error messages and troubleshooting information.
