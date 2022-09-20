function enviar(emailId, telefono)
{
if( ValidarNroTel(telefono) && validateEmail(emailId))
{
alert("Formulario enviado");
}
else
{
alert("Formulario no enviado");
}
}


function validateEmail(emailId)
{
var mailformat = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
if(emailId.value.match(mailformat))
{
document.form1.email.focus();
return true;
}
else
{
alert("Mail ingresado no es valido");
document.form1.email.focus();
return false;
}
} 


function ValidarNroTel(telefono)
{
 var nrotel = /^\d{10}$/;
 if((telefono.value.match(nrotel)))
 {
 return true;
 }
 else
 {
 alert("teléfono inválido (Maximo 10 digitos)");
 return false;
 }
}
