<!DOCTYPE html>
<html>
  <head>
    <meta charset="UTF-8">
    <title>Slide Show</title>
    <style>
      .slider-container {
        position: relative;
        width: 100%;
        z-index: 0;
      }
      .slider {
        position: relative;
        overflow: hidden;
        width: 100%;
        height: 400px;
      }
      .slider img {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        opacity: 0;
        transition: opacity .5s ease-in-out;
      }
      .slider img.active {
        opacity: 1;
      }
      .slider-controls {
        position: absolute;
        bottom: 10px;
        left: 50%;
        z-index: 10;
        display: flex;
        justify-content: center;
        transform: translateX(-50%);
      }
      .slider-control {
        background: transparent;
        border: none;
        outline: none;
        font-size: 20px;
        margin: 0 10px;
        cursor: pointer;
      }
    </style>
  </head>
  <body>
    <div class="slider-container">
      <div class="slider">
        <img src="images/banner3.jpg" alt="Image 1">
        <img src="images/banner4.png" alt="Image 2">
      </div>
      <div class="slider-controls">
        <button class="slider-control prev" onclick="prevSlide()">&#10094;</button>
        <button class="slider-control next" onclick="nextSlide()">&#10095;</button>
      </div>
    </div>
    <script>
      let slideIndex = 0;
      const slides = document.querySelectorAll('.slider img');
      const sliderControls = document.querySelector('.slider-controls');

      function showSlide(n) {
        if (n < 0) {
          slideIndex = slides.length - 1;
        } else if (n >= slides.length) {
          slideIndex = 0;
        } else {
          slideIndex = n;
        }
        slides.forEach((slide) => {
          slide.classList.remove('active');
        });
        slides[slideIndex].classList.add('active');
      }

      function nextSlide() {
        showSlide(slideIndex + 1);
      }

      function prevSlide() {
        showSlide(slideIndex - 1);
      }

      // automatically slide next
      setInterval(() => {
        nextSlide();
      }, 2000);

      // add event listener to controls
      sliderControls.addEventListener('click', (event) => {
        const target = event.target.closest('.slider-control');
        if (target) {
          if (target.classList.contains('prev')) {
            prevSlide();
          } else if (target.classList.contains('next')) {
            nextSlide();
          }
        }
      });
    </script>
  </body>
</html>