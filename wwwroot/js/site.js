// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

  $(".menu-icon").click(() => {
    var x = document.getElementById("nav-menu");
    if (x.className === "nav-container margin-container") {
      x.className += " responsive";
    } else {
      x.className = "nav-container margin-container";
    }
  });
  
  $("#btn-minus").click(() => {
    var amount = parseInt($(".amount").val());
    if(amount > 1) {
    amount -= 1;
    $(".amount").val(amount);
    }
  });

  $("#btn-plus").click(() => {
    var amount = parseInt($(".amount").val());
    amount += 1;
    $(".amount").val(amount);
  });

  $(".read-more-btn").click(() => {
    $(".read-more").css("display", "inline");
    $(".read-more-btn").css("display", "none");
  });