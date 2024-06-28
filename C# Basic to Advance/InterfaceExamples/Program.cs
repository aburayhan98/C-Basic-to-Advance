
using InterfaceExamples;

IWelcomeEmailSender emailSender = new TextEmailSender();

Membership membership = new Membership(emailSender);

membership.Signup("abc@gmail.com", "1234");
