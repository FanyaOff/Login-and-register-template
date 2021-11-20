<?php
        include 'db.php';
		$link = mysqli_connect($servername, $username, $password, $database);


        if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
        }
		
		$username = $_GET['username'];
		$password = $_GET['password']; 

		$query = 'SELECT*FROM users WHERE username="'.$username.'"';
		$result = mysqli_query($link, $query);
		$user = mysqli_fetch_assoc($result);


	if (!empty($user)) {
			echo "nope";
	} else {
		$query2 = "INSERT INTO users (username,password) VALUES('$username','$password')";
			$result2 = mysqli_query($link, $query2);
			   
            if ($result2=='TRUE')
            {
            echo "reg";
            }
            else {
            echo "noreg";
            }	
	}	
	
?>