const smile = ` <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-emoji-smile-upside-down-fill" viewBox="0 0 16 16">
<path d="M8 0a8 8 0 1 1 0 16A8 8 0 0 1 8 0zM7 9.5C7 8.672 6.552 8 6 8s-1 .672-1 1.5.448 1.5 1 1.5 1-.672 1-1.5zM4.285 6.433a.5.5 0 0 0 .683-.183A3.498 3.498 0 0 1 8 4.5c1.295 0 2.426.703 3.032 1.75a.5.5 0 0 0 .866-.5A4.498 4.498 0 0 0 8 3.5a4.5 4.5 0 0 0-3.898 2.25.5.5 0 0 0 .183.683zM10 8c-.552 0-1 .672-1 1.5s.448 1.5 1 1.5 1-.672 1-1.5S10.552 8 10 8z"/>
</svg>
`
const sad = `<svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="bi bi-emoji-neutral-fill" viewBox="0 0 16 16">
<path d="M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zM7 6.5C7 7.328 6.552 8 6 8s-1-.672-1-1.5S5.448 5 6 5s1 .672 1 1.5zm-3 4a.5.5 0 0 1 .5-.5h7a.5.5 0 0 1 0 1h-7a.5.5 0 0 1-.5-.5zM10 8c-.552 0-1-.672-1-1.5S9.448 5 10 5s1 .672 1 1.5S10.552 8 10 8z"/>
</svg>
`
let exam = prompt("Puaninizi giriniz")
let textInfo;
let info= document.querySelector("#info")

if(exam >=0 && exam <=100){
    textInfo= smile
    info.classList.add('text-primary')
if(exam >= 90){textInfo="AA";}
else if (exam >= 85 ){textInfo += " BA";}
else if (exam >= 80 ){textInfo += " BB";}
else if (exam >= 75 ){textInfo += " CB";}
else if (exam >= 70 ){textInfo += " CC";}
else if (exam >= 65 ){textInfo += " DC";}
else if (exam >= 60 ){textInfo += " DD";}
else if (exam >= 55 ){textInfo += " FD";}
else if (exam < 50 ){
textInfo = `${sad} FF`;
info.classList.remove('text-primary')
info.classList.add('text-danger')
}
}
else{
    textInfo= "Bilgiler doğru değil lütfen sayfayı yenileyin..."
}

info.innerHTML= `${textInfo}--> ${exam}`
