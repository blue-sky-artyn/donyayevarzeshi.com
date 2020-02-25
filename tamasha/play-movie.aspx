<%@ Page Language="C#" AutoEventWireup="true" CodeFile="play-movie.aspx.cs" Inherits="play_movie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <video id="video1" controls><source src="video/gallery/lines1.mp4" type="video/mp4" />Your browser does not support HTML5 video.</video>


            <a onclick='playPause();'>Play</a>
        </div>
    </form>





    <script> 
        var myVideo = document.getElementById("video1");

        function playPause1() {

            if (myVideo.paused)
                myVideo.play();
            else
                myVideo.pause();
        }

        function makeBig() {
            myVideo.width = 560;
        }

        function makeSmall() {
            myVideo.width = 320;
        }

        function makeNormal() {
            myVideo.width = 420;
        }
    </script>
</body>
</html>
