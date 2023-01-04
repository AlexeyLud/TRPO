document.addEventListener('DOMContentLoaded', () => {
	const scrollItems = document.querySelectorAll('.scroll-item');
    const scrollAnimation = () => {
		let windowCenter = (window.innerHeight) + window.scrollY;
		console.log(windowCenter)
		scrollItems.forEach(el => {
			let scrollOffset = el.offsetTop + (el.offsetHeight / 2);
			if (windowCenter >= scrollOffset) {
				el.classList.add('animation-class');
			} else {
				el.classList.remove('animation-class');
			}
		});
	};

    scrollAnimation();

    window.addEventListener('scroll', () => {
		scrollAnimation();
	});
});

const anchors = document.querySelectorAll('a[href^="#"]')

for(let anchor of anchors) {
  anchor.addEventListener("click", function(e) {
    e.preventDefault()
	const BlockId = anchor.getAttribute('href')
    document.querySelector('' + BlockId).scrollIntoView({
      behavior: "smooth",
      block: "start"
    })
  })
}

anchors = document.querySelectorAll('form[action^="#"]')

for(let anchor of anchors) {
	anchor.addEventListener("click", function(e) {
	  e.preventDefault()
	  const BlockId = anchor.getAttribute('action')
	  document.querySelector('' + BlockId).scrollIntoView({
		behavior: "smooth",
		block: "start"
	  })
	})
}
  