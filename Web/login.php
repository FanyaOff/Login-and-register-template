<?php
        include 'db.php';
		$link = mysqli_connect($servername, $username, $password, $database);


        if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
        }
		
		$username = $_GET['username'];
		$password = $_GET['password']; 

		$query = 'SELECT*FROM users WHERE username="'.$username.'" AND password="'.$password.'"';
		$result = mysqli_query($link, $query); //ответ базы запишем в переменную $result. 
		$user = mysqli_fetch_assoc($result); //преобразуем ответ из БД в нормальный массив PHP

		//Если база данных вернула не пустой ответ - значит пара логин-пароль правильная
		if (!empty($user)) {
			echo "da";
		} else {
			echo "net";
		}
?>