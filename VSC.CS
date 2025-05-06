<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
        <title>SECRET WORD</title>
    </head>
    <body>
        <center><h2>WORD GAME</h2></center>
        <hr/>
        <div class="row justify-content-center row-cols-1 row-cols-md-2 mb-3 text-center">
            <div class="col">
                <div class="card mb-4 rounded-3 shadow-sw">
                    <div class="card-header py-3">
                        <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="red" class="bi bi-ui-checks" viewBox="0 0 16 16">
                        <path d="M7 2.5a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-7a.5.5 0 0 1-.5-.5zM2 1a2 2 0 0 0-2 2v2a2 2 0 0 0 2 2h2a2 2 0 0 0 2-2V3a2 2 0 0 0-2-2zm0 8a2 2 0 0 0-2 2v2a2 2 0 0 0 2 2h2a2 2 0 0 0 2-2v-2a2 2 0 0 0-2-2zm.854-3.646a.5.5 0 0 1-.708 0l-1-1a.5.5 0 1 1 .708-.708l.646.647 1.646-1.647a.5.5 0 1 1 .708.708zm0 8a.5.5 0 0 1-.708 0l-1-1a.5.5 0 0 1 .708-.708l.646.647 1.646-1.647a.5.5 0 0 1 .708.708zM7 10.5a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-7a.5.5 0 0 1-.5-.5zm0-5a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5m0 8a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5"/>
                        </svg>&nbsp;&nbsp;<font style="font-size: 30px;"><b></b>SECRET WORD</font>
                    </div>
                    <div class="card-body">
                        <form action="resultado.php" method="post">
                            <label class="form-label">WRITE A WORD</label>
                            <input class="form-control" type="text" name="palavra" required placeholder="WRITE YOUR WORD">
                            <br/>         
                            <input type="submit" class="btn btn-outline-success" value="start game"/>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </body>
</html>

------------------------- ---------------------------------------- ------------------------ ------------------------------------------------- ------------------------------------------------ ------------------------------


<?php
    session_start();
    if ($_SERVER['REQUEST_METHOD']=='POST' && isset($_POST['palavra'])) {
        $_SESSION['palavra'] = strtolower(trim($_POST['palavra']));
        $_SESSION['tentativas'] = 3;
    }
    $jogoencerrado = false;
    if (!isset($_SESSION['palavra'])) {
        header(header: "Location:index.php");
        exit;
    }
    $palavra = $_SESSION['palavra'];
    $tamanho = strlen(string: $palavra);
    $msg = '';
    if (isset($_POST['chute'])) {
        $chute = strtolower(string: trim(string: $_POST['chute']));
        $_SESSION['tentativas']--;
        if ($chute === $palavra) {
            $msg = "<div class='alert alert-success'>congratulation! Você acertou a palavra: <strong>$palavra</strong></div>";
            $jogoencerrado = true;
        } elseif ($_SESSION['tentativas'] <= 0) {
            $msg = "<div class='alert alert-danger'>you lost! the word was: <strong>$palavra</strong></div>";
            $jogoencerrado = true;
        } else {
            $msg = "<div class='alert alert-warning'>wrong! remaining attempts: <strong>{$_SESSION['tentativas']}</strong></div>";
        }
        if ($jogoencerrado) {
            session_unset();
            session_destroy();
            header(header: "Refresh: 5;URL=index.php");
        }
    }
?>
<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
        <title>Palavra Secreta</title>
    </head>
    <body>
        <center><h2>GAME WORD</h2></center>
        <hr/>
        <div class="row justify-content-center row-cols-1 row-cols-md-2 mb-3 text-center">
            <div class="col">
                <div class="card mb-4 rounded-3 shadow-sw">
                    <div class="card-header py-3">
                        <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="red" class="bi bi-ui-checks" viewBox="0 0 16 16">
                        <path d="M7 2.5a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-7a.5.5 0 0 1-.5-.5zM2 1a2 2 0 0 0-2 2v2a2 2 0 0 0 2 2h2a2 2 0 0 0 2-2V3a2 2 0 0 0-2-2zm0 8a2 2 0 0 0-2 2v2a2 2 0 0 0 2 2h2a2 2 0 0 0 2-2v-2a2 2 0 0 0-2-2zm.854-3.646a.5.5 0 0 1-.708 0l-1-1a.5.5 0 1 1 .708-.708l.646.647 1.646-1.647a.5.5 0 1 1 .708.708zm0 8a.5.5 0 0 1-.708 0l-1-1a.5.5 0 0 1 .708-.708l.646.647 1.646-1.647a.5.5 0 0 1 .708.708zM7 10.5a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5h-7a.5.5 0 0 1-.5-.5zm0-5a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5m0 8a.5.5 0 0 1 .5-.5h5a.5.5 0 0 1 0 1h-5a.5.5 0 0 1-.5-.5"/>
                        </svg>&nbsp;&nbsp;<font style="font-size: 30px;"><b>PALAVRA SECRETA</b></font>
                    </div>
                    <div class="card-body">
                        <h3>Dica: A palavra tem <strong><?php echo $tamanho; ?> letras.</strong></h3>
                        <?php if(!empty($msg)) echo $msg; ?>
                        <?php if(!$jogoencerrado): ?>
                        <form action="resultado.php" method="post">
                            <label class="form-label">Digite uma palavra</label>
                            <input class="form-control" type="text" name="chute" required placeholder="Digite uma palavra"/>
                            <br/>
                            <input type="submit" class="btn btn-outline-success" value="INICIAR O JOGO"/>
                        </form>
                        <?php else: ?>
                            <a href="index.php" class="btn btn-secondary">RECOMEÇAR</a>
                            <p class="text-muted mt-2">Você será redirecionado em alguns segundos...</p>
                        <?php endif; ?>
                    </div>
                </div>
            </div>
        </div>
    </body>
</html>
