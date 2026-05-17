# 📧 Email System - Quick Reference

## Current Email Configuration

```
From Email: raminisetty.sukhesh@bcah.christuniversity.in
Password: 1234
SMTP Server: smtp.gmail.com
Port: 587
SSL Enabled: Yes
```

## ⚠️ IMPORTANT: Update Your Credentials!

The current credentials are placeholders. You MUST update them for emails to work:

### **Update in EmailHelper.cs (Lines 9-13):**

```csharp
private const string FROM_EMAIL = "your.actual.email@gmail.com";      // ← Change this
private const string EMAIL_PASSWORD = "your_app_password";             // ← Change this
private const string SMTP_HOST = "smtp.gmail.com";                     // Keep as is for Gmail
private const int SMTP_PORT = 587;                                     // Keep as is for Gmail
private const bool ENABLE_SSL = true;                                  // Keep as is for Gmail
```

## 🔄 How Email Flow Works

1. **User saves a parcel** in Parcel Entry tab
2. **System calls** `EmailHelper.SendNotification(studentEmail, trackingNumber)`
3. **Email is formatted** with HTML template including:
   - Parcel arrival notification
   - Tracking number
   - Collection instructions
   - Office hours
4. **SMTP connects** to Gmail server on port 587
5. **Email is sent** to student's inbox
6. **Success/Error message** is displayed to user
7. **Console logs** the result for debugging

## ✅ Email Features

| Feature | Status |
|---------|--------|
| HTML Formatted | ✅ Active |
| Tracking Number | ✅ Included |
| Collection Instructions | ✅ Included |
| Office Hours | ✅ Included |
| Error Handling | ✅ Active |
| Console Logging | ✅ Active |
| Test Function | ✅ Available |

## 🧪 Quick Test

### **Option 1: Send a Parcel**
1. Go to "Parcel Entry" tab
2. Search and select a student
3. Enter tracking number (e.g., A1234)
4. Click "Save Parcel"
5. Check student's email inbox

### **Option 2: Test Function (if added to UI)**
```csharp
bool result = EmailHelper.TestEmailConfiguration("student@email.com");
// Returns true if successful, false if failed
```

## 📊 Email Status Codes

| Code | Meaning | Solution |
|------|---------|----------|
| GeneralFailure | SMTP connection failed | Check internet connection |
| ServiceNotAvailable | Server temporarily down | Try again later |
| MailboxBusy | Mailbox is busy | Retry the operation |
| BadCommandSequence | SMTP config error | Verify SMTP settings |
| ClientNotPermitted | Auth failed | Check email credentials |

## 🔍 Debugging

### **Enable Console Output**
- Open **Output** window in Visual Studio (View → Output)
- Select **Debug** from dropdown
- Try sending an email
- Look for messages starting with `[Email]` or `[✓]` or `[✗]`

### **Sample Success Message:**
```
[✓ Email Sent Successfully] To: student@email.com, Tracking: A1234
```

### **Sample Error Message:**
```
[✗ SMTP Error] The server responded with: 535 5.7.8 Username and Password not accepted
```

## 🛠️ Common Issues & Fixes

### **Gmail Says "App password required"**
→ Use 16-character App Password instead of account password

### **Gmail Says "Less secure apps access required"**
→ Enable at: https://myaccount.google.com/security

### **Email doesn't send (silent failure)**
→ Check Output window console for error messages

### **"Timeout" error**
→ Increase timeout value from 10000 to 20000 (milliseconds)

### **"Authentication failed"**
→ Verify email and password are correct in EmailHelper.cs

## 📧 Email Template Preview

Students will receive emails with:

```
Header: 📦 Parcel Arrival Notification
Subject: 🎉 Your Parcel Has Arrived!

Body:
- Welcome message
- Large tracking number display
- 3-step collection instructions
- Office hours
- Support contact info
- Professional footer

Styling: 
- Green (#00a651) accent color
- Clean professional layout
- Easy-to-read formatting
- Mobile-responsive
```

## 🔐 Security Reminders

⚠️ **NEVER:**
- Commit credentials to GitHub
- Share credentials in chat/email
- Use main Gmail password (use App Password)
- Store credentials in config files

✅ **DO:**
- Use App Passwords for Gmail
- Store in Environment Variables (production)
- Rotate credentials periodically
- Use separate email accounts per environment

## 📞 Need Help?

1. Check the **Output** window in Visual Studio
2. Look for error messages with `[✗]` prefix
3. Review `EMAIL_SETUP_GUIDE.md` for detailed instructions
4. Verify credentials are correct in `EmailHelper.cs`
5. Ensure internet connection is active

---

**Last Updated:** Current Session
**Status:** Ready to Use (Update Credentials Required)
