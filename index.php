<!DOCTYPE html>
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <link rel="stylesheet" href="/Styles/styles.css">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@300&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.7.2/css/all.css" 
    integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" crossorigin="anonymous">
    <link href="https://fonts.googleapis.com/css2?family=Montserrat:wght@300;900&display=swap" rel="stylesheet">
    <title>Главная страница</title>
  </head>
  <body link="white" vlink="white" alink="white">

    <div class="upperst">
        <nav>
          <div style="width: 20%; text-align: left; float: left;" class="logo_menu">
            <form action="#index.php">
              <input class="btn_logo" type="image" src="/pictures/маленькое.png" alt="LookTo">
            </form>
          </div>
          <div style="width: 80%; text-align: right; float: left;" class="menu">
          <div class="text-element" style="width: 90%; text-align: right; float: left;" id="menu">
              <a class="menu_el" id="live" href="#t1">Трансляции</a>
              <a class="menu_el" id="mentor" href="#t2">Менторы</a>
              <a class="menu_el" id="us" href="#t3">О нас</a>
              <a class="menu_el" id="help" href="#t4">Обратная связь</a>
              <a class="menu_el" id="sign" href="config\authorization.html">Регистрация/Войти</a>
          </div>
          <div class="image-element" style="width: 3%; text-align: left; float: left;">
            <a class="image_el" href="config\profile.php">
              <img class="logo_user" src="/pictures/not_avatar.jpg" alt="user" id="logo_user">
            </a>
          </div>
          </div>
        </nav>

      <div class="info_main">
        <div style="width: 50%; text-align: left; float: left;" class="info">
          <div id="describe" class="scroll-item">
            <div class="frase">Сегодня увидел - завтра сделал</div>
            <div class="smt"> Веб-приложение, где можно узнать много нового о будущей работе и не только </div>
            <a href="#t3" id="btn_us">
              <div class="btn_us">
                Коротко о проекте
              </div>
            </a>
          </div> <br>
        </div>
        <div style="width: 50%; text-align: right; float: left;" class="logo">
          <img class="scroll-item" src="/pictures/большое.png" alt="LookTo" id="logo_picture">
        </div>
      </div>
    </div>

    <div class="why_we">
      <h2>Почему именно мы?</h2>
      <div class="inside scroll-item">
        <div class="reason">
          <div class="block">
            <div class="pict1">
                <img src="/pictures/support.png" alt="support" id="support">
            </div>
            <div class="text">
              <h3>Честность</h3>
              <div class="d">Только правда о работе в мире IT</div>
            </div>
          </div>
        </div>
        <div class="reason">
          <div class="block">
            <div class="pict2">
                <img src="/pictures/learning.png" alt="simple" id="simple">
            </div>
            <div class="text">
              <h3>Простота</h3>
              <p class="d">Тяжелые вещи простыми словами</p>
            </div>
          </div>
        </div>
        <div class="reason">
          <div class="block">
            <div class="pict3">
                <img src="/pictures/brain.png" alt="quality" id="quality">
            </div>
            <div class="text">
              <h3>Квалифицированность</h3>
              <p class="d">Опытные в своей области специалисты</p>
            </div>
          </div>
        </div>
      </div>    
    </div>

    <div class="vebinar">
      <h2 id="t1">Трансляции</h2> 
      <div class="line">
        <div class="plan">
          <div class="h_plan">
            <h4>Запланированные</h4>
          </div>
          <div class="list_broadcast"> 
            <div class="item_broadcast">
              <form action="#">
                <input class="plus" type="image" src="\pictures\плюсик.png" alt="LookTo">
              </form>
              <iframe class="item" width="900" height="506" src="https://www.youtube.com/embed/r3l8L-9RE-k" title="YouTube video player" 
              frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" 
              allowfullscreen></iframe>
            </div>
            <div class="item_broadcast">
              <form action="#">
                <input class="plus" type="image" src="\pictures\плюсик.png" alt="LookTo">
              </form>
              <iframe class="item" width="900" height="506" src="https://www.youtube.com/embed/r3l8L-9RE-k" title="YouTube video player" 
              frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" 
              allowfullscreen></iframe>
            </div>
            <div class="item_broadcast">
              <form action="#">
                <input class="plus" type="image" src="\pictures\плюсик.png" alt="LookTo">
              </form>
              <iframe class="item" width="900" height="506" src="https://www.youtube.com/embed/r3l8L-9RE-k" title="YouTube video player" 
              frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" 
              allowfullscreen></iframe>
            </div>
          </div>
        </div>
        <div class="live">
          <div class="h_now">
            <h4>Прямой эфир</h4>
          </div> 
          <div class="live_broadcast">
            <iframe class="big_item" width="750" height="450" src="https://www.youtube.com/embed/r3l8L-9RE-k" title="YouTube video player" 
              frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" 
              allowfullscreen></iframe>
          </div>   
        </div>
      </div>   
    </div>
    
    <div class="mentors">
      <h2 id="t2">О нас</h2>
      <div class="card scroll-item">
        <div class="line">
          <div class="card__item">
            <div class="card__inner">
              <div class="card__img" >
                <img class="images" id="pct1" src="/pictures/1.jpg" alt="">
              </div>
              <div class="card__text">
                <div class="social">
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-facebook-f"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-twitter"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-instagram"></i>
                  </a>
                </div>
              </div>
            </div>  
          </div>

          <div class="card__item">
            <div class="card__inner">
              <div class="card__img">
                <img class="images" id="pct3" src="/pictures/3.jpg" alt="">
              </div>
              <div class="card__text">
                <div class="social">
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-facebook-f"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-twitter"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-instagram"></i>
                  </a>
                </div>
              </div>
            </div>
          </div>

          <div class="card__item">
            <div class="card__inner">
              <div class="card__img">
                <img class="images" id="pct5" src="/pictures/5.jpg" alt="">
              </div>
              <div class="card__text">
                <div class="social">
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-facebook-f"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-twitter"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-instagram"></i>
                  </a>
                </div>
              </div>
            </div>
          </div>
        </div>

        <div class="line" id="down">
          <div class="card__item">
            <div class="card__inner">
              <div class="card__img">
                <img class="images" id="pct2" src="/pictures/2.jpg" alt="">
              </div>
              <div class="card__text">
                <div class="social">
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-facebook-f"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-twitter"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-instagram"></i>
                  </a>
                </div>
              </div>
            </div>  
          </div>

          <div class="card__item">
            <div class="card__inner">
              <div class="card__img">
                <img class="images" id="pct4" src="/pictures/4.jpg" alt="">
              </div>
              <div class="card__text">
                <div class="social">
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-facebook-f"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-twitter"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-instagram"></i>
                  </a>
                </div>
              </div>
            </div>
          </div>

          <div class="card__item">
            <div class="card__inner">
              <div class="card__img">
                <img class="images" id="pct6" src="/pictures/6.jpg" alt="">
              </div>
              <div class="card__text">
                <div class="social">
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-facebook-f"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-twitter"></i>
                  </a>
                  <a class="social__item" href="#" target="_blank">
                    <i class="fab fa-instagram"></i>
                  </a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <h2 id="t3">О проекте LookTo</h2>
      <div class="line">
        <div class="text_us">
          <h3> Мы - команда молодых программистов</h3>
          <p class="describe_us">Наша главная идея заключается в<br> том, чтобы помочь начинающим <br>
            коллегам устранить пробел в <br>знаниях о работе в IT сфере и не <br>только. 
            Найти себе ментора, <br>определится с направлением,<br>вдохновится на изучение 
            нового и<br>успешно найти себя в будущем.</p>
        </div>
        <div class="hard_pict scroll-item">
          <img class="main_pct" src="/pictures/people.png" alt="people">
        </div>
      </div>
    </div>

    <div class="questions">
      <h2 style="color:white;" id="t4">Есть вопросы? Задавайте!</h2>
      <form action="/config/answer.html" class="form_qst">
        <input type="text" class="input_qst" name="nam" id="nam" placeholder="Введите имя" required>
        <input type="text" class="input_qst" name="email" id="email" placeholder="Введите Email" required><br>
        <input type="text" class="input_qst" name="surname" id="surname" placeholder="Введите фамилию" required>
        <input type="text" class="input_qst" name="topic" id="topic" placeholder="Тема вопроса" required> <br>
        <div class="line">
          <textarea name="qst" id="qst" class="input_qst" cols="60" rows="5" placeholder="Введите сообщение" required></textarea>
          <input type="submit" class="send" value="&#8594">
        </div>
      </form>
    </div>

    <footer>
      <div class="footer_left">
        <img class="btn_logo_down" src="/pictures/маленькое.png" alt="LookTo" id="logo_footer">
        <h2 class="name">LookTo</h2>
      </div>

      <div class="footer_center">
        <p>2021 Все права защищены</p>
      </div>

      <div class="footer_right">
          <p class="tel">+375 (29) 7208588</p>
      </div>
    </footer>
    <script src="/js_script/script.js"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.1/jquery.min.js"></script>
  </body>
</html>
