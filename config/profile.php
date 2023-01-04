<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="/Styles/styles.css">
    <link rel="stylesheet" href="/Styles/profile.css">
    <link rel="stylesheet" href="/Styles/submit.css">
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@300&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css" 
    integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@300;900&display=swap" rel="stylesheet">
    <title>Ваш профиль</title>
</head>
<body>
    <div class="upper">
        <div class="header">
            <form action="/../">
                <input class="btn_logo" type="image" src="/../pictures/logo_small_new.png" alt="LookTo">
            </form>
        </div>
        <div class="status">
            <div class="text">Статус: не знаю</div>   
        </div>
    </div>
    <div class="profile">
        <div class="broadcasts" id="left">
            <div class="view">
                <h3 align="center" style="color:red;">Запланированные трансляции</h3>
                <div class="video" id="left_video">
                    <div class="frame">
                        <iframe width="270" height="152" src="https://www.youtube.com/embed/CzUOJb4ITCs" title="YouTube video player" frameborder="0"
                            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                        <div align="center">Название трансляции</div>
                    </div>
                    <div class="frame">
                        <iframe width="270" height="152" src="https://www.youtube.com/embed/CzUOJb4ITCs" title="YouTube video player" frameborder="0"
                            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                        <div align="center">Название трансляции</div>
                    </div>
                    <div class="frame">
                        <iframe width="270" height="152" src="https://www.youtube.com/embed/CzUOJb4ITCs" title="YouTube video player" frameborder="0"
                            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                        <div align="center">Название трансляции</div>
                    </div>
                    <div class="frame">
                        <iframe width="270" height="152" src="https://www.youtube.com/embed/CzUOJb4ITCs" title="YouTube video player" frameborder="0"
                            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                        <div align="center">Название трансляции</div>
                    </div>
                </div>
            </div>
        </div>
        <div class="information" id="center">  
            <div class="avatar">
                <img class="profile_avatar" src="/pictures/Tupik.png" alt="user" id="profile_avatar">
            </div>
            <div class="names">
                <div class="nickname">
                    denchik  
                </div>
                <div class="first_last">
                    Tupik Denis
                </div>
            </div>
            <br>
            <div class="buttons">
                <div class="btn_row">
                    <form action="change_info.html">
                        <input type="submit" class="submit btn-profile" id="info" value="Редактировать профиль">
                    </form>
                    <form action="specialist.html">
                        <input type="submit" class="submit btn-profile" id="mentor" value="Стать ментором">
                    </form>
                    <form action="create_broadcast.html">
                        <input type="submit" class="submit btn-profile" id="broadcast" value="Создать трансляцию">
                    </form>
                </div>
                <br>
                <div class="btn_row">
                    <form action="#">
                        <input type="submit" class="submit btn-profile" id="nmb_mentor" value="Заявки на ментерство">
                    </form>
                    <form action="list_specialist.html">
                        <input type="submit" class="submit btn-profile" id="list" value="Список менторов">
                    </form>
                </div>
                <div class="btn_row">
                    <form action="add_specialist.html">
                        <input type="submit" class="submit btn-profile" id="add" value="Сделать ментором">
                    </form>
                    <form action="#">
                        <input type="submit" class="submit btn-profile" id="exit" value="Выход">
                    </form>
                </div>
            </div>
        </div>
        <div class="broadcasts" id="right">  
        <div class="view">
                <h3 align="center" style="color:green;" >Завершённые трансляции</h3>
                <div class="video" id="right_video">
                    <div class="frame">
                        <iframe width="270" height="152" src="https://www.youtube.com/embed/CzUOJb4ITCs" title="YouTube video player" frameborder="0"
                            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                        <div align="center">Название трансляции</div>
                    </div>
                    <div class="frame">
                        <iframe width="270" height="152" src="https://www.youtube.com/embed/CzUOJb4ITCs" title="YouTube video player" frameborder="0"
                            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                        <div align="center">Название трансляции</div>
                    </div>
                    <div class="frame">
                        <iframe width="270" height="152" src="https://www.youtube.com/embed/CzUOJb4ITCs" title="YouTube video player" frameborder="0"
                            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                        <div align="center">Название трансляции</div>
                    </div>
                    <div class="frame">
                        <iframe width="270" height="152" src="https://www.youtube.com/embed/CzUOJb4ITCs" title="YouTube video player" frameborder="0"
                            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                        <div align="center">Название трансляции</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>