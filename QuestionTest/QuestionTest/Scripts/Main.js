
$(function ()
{ 
  $('#SubmitBtn').on('click', function(e)
  { 
      e.preventDefault();
      $('.danger').empty();
      var isValid = true;
      
      if ( ! $('.gender').is(':checked') )
          {
          $('#genderValidMes').html( "Данное поле обязательно для заполнения");
            isValid= false;
          }
   
      if (($('#phoneBrand').val()) == 0 )
          {
          $('#brandValidMes').html( "Данное поле обязательно для заполнения");
           isValid= false;
          }
    
      if (isValid)    
          SendRequest();             
    });        
      
      
  })


function SendRequest()
{
    $.ajax({
               'url' : '/Home/GetData', 
               'data' : {
                   'Sex' :$("input[name='Sex']:checked").val(),
                   'PhoneBrand' : $('#phoneBrand').val()
                        } ,        
               'success' : function(data) {              
                   if (data == "True")
                       $('body').empty().html("<p class='thanks'> Спасибо за ответы!</p> ");
                   else alert(data);
                       
                                    }
                    });
}