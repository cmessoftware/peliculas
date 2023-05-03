// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// 2. This code loads the IFrame Player API code asynchronously.
var tag = document.createElement('script');

tag.src = "https://www.youtube.com/iframe_api";
var firstScriptTag = document.getElementsByTagName('script')[0];
firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);

// 3. This function creates an <iframe> (and YouTube player)
//    after the API code downloads.
var player;
function onYouTubeIframeAPIReady() {
    player = new YT.Player('player', {
        height: '360',
        width: '640',
        videoId: 'M7lc1UVf-VE',
        events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
        }
    });
}

// 4. The API will call this function when the video player is ready.
function onPlayerReady(event) {
    event.target.playVideo();
}

// 5. The API calls this function when the player's state changes.
//    The function indicates that when playing a video (state=1),
//    the player should play for six seconds and then stop.
var done = false;
function onPlayerStateChange(event) {
    if (event.data == YT.PlayerState.PLAYING && !done) {
        setTimeout(stopVideo, 6000);
        done = true;
    }
}
function stopVideo() {
    player.stopVideo();
}

//Usado en la vista parcial _Cines

const mostrarCines = () => {
    console.log("Se hizo click en id mostrarCines ")
    //Consulto al controlador de cines.



    //var x = document.getElementById("mostrarImgCines");
    //if (x.style.display === "none") {
    //    x.style.display = "block";
    //} else {
    //    x.style.display = "none";
    //}
}

const actions = {
    click: {
        mostrarCines,
    },
    mouseover: {
        mostrarCines: console.log("mouse over"),
    }
};

Object.keys(actions).forEach(key => document.addEventListener(key, handle));

function handle(evt) {
    const origin = evt.target.closest("[data-action]");
    return origin &&
        actions[evt.type] &&
        actions[evt.type][origin.dataset.action] &&
        actions[evt.type][origin.dataset.action](origin, evt) ||
        true;
}


function displayImage(src, width, height) {
    var img = document.createElement("img");
    img.src = src;
    img.width = width;
    img.height = height;
    document.body.appendChild(img);
}
