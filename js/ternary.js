let userName = prompt("Kullanici adinizi giriniz: ")
let info = document.querySelector("#info")
info.innerHTML = `${userName.length > 0 ? userName : "Kullanici bilginiz bulunamadi :("} `