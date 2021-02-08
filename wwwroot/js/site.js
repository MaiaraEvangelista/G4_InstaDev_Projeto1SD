// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var btn = document.getElementById('btn');

function Toggle(){
    if(btn.classList.contains("far")){
        btn.classList.remove("far");
        btn.classList.add("fas");
    }
    else{
        btn.classList.remove("fas");
        btn.classList.add("far");
    }
}

$(document).ready(function(){
    $('.content-txt').click(function(){
      $('.numb').toggleClass("heart-active")
    });
  });
