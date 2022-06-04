const swiper = new Swiper('.main-swiper', {
  // Optional parameters
  direction: 'horizontal',
  loop: true,

  // If we need pagination
  pagination: {
    el: '.swiper-pagination',
    clickable: true,
  },

  // Navigation arrows
  navigation: {
    nextEl: '.swiper-button-next',
    prevEl: '.swiper-button-prev',
  },

  autoplay: {
      delay: 5000,
      disableOnInteraction: false,
    },
});

  const newproductswiper = new Swiper('.product-slider-swiper', {
    // Optional parameters
    direction: 'horizontal',

    // Navigation arrows
    navigation: {
      nextEl: '.swiper-button-next',
      prevEl: '.swiper-button-prev',
    },

    autoplay: {
        delay: 4000,
        disableOnInteraction: false,
      },

    slidesPerView: 2,

    breakpoints: {
      600: {
        slidesPerView: 5,
      }
    }
  });