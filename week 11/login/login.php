<html>
    <head>
        <title>Login!</title>
        <link href="styles.css" type="text/css" rel="stylesheet" >
            
    </head>
    <body>
        <form action="checklogin.php" method="POST">
        <table>
            <tr>
                <td colspan="2" align="center">
                    <?php if(isset($_GET["error"]))
                    {
                        echo ("Invalid username/hkey combination");
                    }
                    ?>
                </td>
            </tr>
            <tr>
                <td>
                    Username:
                </td>
                <td>
                    <input type="text" name="username">
                </td>
            </tr>
            <tr>
                <td>
                    Password:
                </td>
                <td>
                    <input type="text" name="hkey">
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <input type="submit" value="Submit">
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <a href="default.php?register=1">Register</a> 
                </td>
            </tr>
        </table>
        
        </form>
    </body>
</html>