const cards = document.querySelectorAll('.cardfc');

function transition() {
  if (this.classList.contains('activecard')) {
    this.classList.remove('activecard');
  } else {
    this.classList.add('activecard');
  }
}

cards.forEach(card => card.addEventListener('click', transition));

var slideIndex = 1;
showDivs(slideIndex);

function plusDivs(n) {
  showDivs(slideIndex += n);
}

function showDivs(n) {
  var i;
  var x = document.getElementsByClassName("slides");
  if (n > x.length) {slideIndex = 1}    
  if (n < 1) {slideIndex = x.length}
  for (i = 0; i < x.length; i++) {
     x[i].style.display = "none";  
  }
  x[slideIndex-1].style.display = "block";  
  document.getElementsByClassName("pagination")[0].innerText = slideIndex + ' / ' + x.length;
}