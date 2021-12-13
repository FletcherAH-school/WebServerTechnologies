<html>
    <head>
        <title>Register user</title>
        <link href="styles.css" type="text/css" rel="stylesheet" >
    </head>

    <body>
    <form action="createuser.php" method="POST">
        <table>
            <tr>
            <td colspan="2" align="center">
                    <?php if(isset($_GET["error"]))
                    {
                        echo ("Passwords must match");
                    }
                    ?>
                </td>
            </tr>
            <tr>
                <td>
                    User Name:
                </td>
                <td>
                    <input type="text" id="username" name="username">
                </td>
            </tr>
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <input type="text" id="hkey" name="hkey">
                </td>
            </tr>
            <tr>
                <td>
                    Confirm Password
                </td>
                <td>
                <input type="text" id="confirmhkey" name="confirmhkey">
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <input type="submit" text="submit">
                </td>
            </tr>
        </table>
        </form>
    </body>
</html>