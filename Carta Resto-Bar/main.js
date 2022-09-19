function validateEmail(emailId)
{
var mailformat = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
if(emailId.value.match(mailformat))
{
document.form1.text1.focus();
return true;
}
else
{
alert("Mail ingresado no es valido");
document.form1.text1.focus();
return false;
}
} 