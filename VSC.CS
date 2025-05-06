<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta name="viewport" content="width-device-width, initial-scale-1">
        <title>UWU - HOMO</title>
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.5/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-SgOJa3DmI69IUzQ2PVdRZhwQ+dy64/BUtbMJw1MZ8t5HZApcHrRKUc4W0kG879m7" crossorigin="anonymous">
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.5/dist/js/bootstrap.bundle.min.js" integrity="sha384-k6d4wzSIapyDyv1kpU366/PK5hCdSbCRGRCMv+eplOQJWyd1fbcAu9OCUj5zNLiq" crossorigin="anonymous"></script>
        <link rel="icon" href="https://institutoamparanimal.org.br/wp-content/uploads/2023/10/gato_preto_ampara_petlove_.png">
        
    </head>
    <body>
        <center><h1>UWU CALC</h1></center>
        <hr>
        <div class="row justify-content-center row-cols-1 row-cols-md-2 mb-3 text-center">
            <div class="col">
                <div class="card mb-4 rounded-3 shadow-sw">
                    <img src="https://institutoamparanimal.org.br/wp-content/uploads/2023/10/gato_preto_ampara_petlove.png" class="card-img-top" height="500">
                    <div class="card-header py-3 text-bg-danger">
                    <h3><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-ui-checks-grid" viewBox="0 0 16 16">
  <path d="M2 10h3a1 1 0 0 1 1 1v3a1 1 0 0 1-1 1H2a1 1 0 0 1-1-1v-3a1 1 0 0 1 1-1m9-9h3a1 1 0 0 1 1 1v3a1 1 0 0 1-1 1h-3a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1m0 9a1 1 0 0 0-1 1v3a1 1 0 0 0 1 1h3a1 1 0 0 0 1-1v-3a1 1 0 0 0-1-1zm0-10a2 2 0 0 0-2 2v3a2 2 0 0 0 2 2h3a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2zM2 9a2 2 0 0 0-2 2v3a2 2 0 0 0 2 2h3a2 2 0 0 0 2-2v-3a2 2 0 0 0-2-2zm7 2a2 2 0 0 1 2-2h3a2 2 0 0 1 2 2v3a2 2 0 0 1-2 2h-3a2 2 0 0 1-2-2zM0 2a2 2 0 0 1 2-2h3a2 2 0 0 1 2 2v3a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2zm5.354.854a.5.5 0 1 0-.708-.708L3 3.793l-.646-.647a.5.5 0 1 0-.708.708l1 1a.5.5 0 0 0 .708 0z"/>
</svg>&nbsp;&nbsp;GATO</h3>
                    </div>
                    <div class="card-body text-bg-danger">
                        <form action="soma.php" method="post">
                            <label class="fprm-label">Digite um valor</label>
                            <input class="form-control" type="number" placeholder="valor" name="n1" required>
                            <br>
                            <label class="fprm-label">Digite um valor</label>
                            <input class="form-control" type="number" placeholder="valor" name="n2" required>
                            <br>
                            <input type="submit" class="btn btn-dark" value="SOMAR">
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </body>
    <script>
        randomcolors = ["green", "yellow"];

        mudarbg();

        function delay() {
            setTimeout(mudarbg, 3000);
        } 

        function mudarbg() {
            document.body.style.background = randomcolors[1];
            delay();
        }
        
    </script>
</html>
