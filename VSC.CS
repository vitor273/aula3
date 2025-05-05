             <?php
               $palavra = $_POST['palavra'];
			   echo "<br/> a palavra digitada foi: ".$palavra;
			  ?> <!DOCTYPE html>
              <html lang = "pt-br">
               <head>
                  <meta name="viewport" content="width=device-width, initial-scale=1">
                  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
                  <title>aula de web</title>
               </head>
                <body>     
                   <center><h2>1 FORMULARIO</h2></center>
                   <hr/>
                    <div class="row justfy-content-center row-cols-1 row-cols-md-2 mb-3 text-center">
                       <div class="col">
                       <div class="card mb4 rounded-3 shadow-sw">
                       <div class="card-header py-3">
                           <svg xmlns="http://www.w3.org/200/svg" width="30" height="30" fill="red" class="bi b">
                           </svg>
                           Titulo
                       </div>				
                       </div class="card-body">
                       <?php
                       $palavra = $_POST['palavra'];
			           echo "<br/> a palavra digitada foi: ".$palavra;
                       echo "<br/><a href='#' class='btn btn-secondary btn-lg disabled' tabindex='-1' role='button' aria-disabled='true'>Link</a>";
			            ?>

                           
                       </div>
                    </div>
                </body>
              </html>
