$(document).ready(function(){
  $(".main").tiltedpage_scroll({
    angle: 20
  });
});


$(window).scroll( function() {
  var wScroll = $(this).scrollTop();
  $('.text-brand').css({
    'transform':'translate(0px,'+wScroll / 5 +  '%)'
  });

  //list product
  if (wScroll > $('.list-product').offset().top - ($(window).height() / 1.3)){
    $('.list-product figure').each(function(i){
        setTimeout(function(){
          $('.list-product figure').eq(i).addClass("run");
        },200 * (i+1));
    });
  }

    ////list product
    //if (wScroll > $('.properties-product').offset().top - ($(window).height() / 1.3)) {
    //    $('.properties-product figure').each(function (i) {
    //        setTimeout(function () {
    //            $('.properties-product figure').eq(i).addClass("run");
    //        }, 200 * (i + 1));
    //    });
    //}



})
