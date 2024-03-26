let ilkSıra = document.querySelector("ul#list>li:first-child")
ilkSıra.innerHTML= "İLK SIRA DEĞİŞİKLİĞİ"

let sonSıra = document.querySelector("ul#list>li:last-child")
sonSıra.innerHTML= "Son SIRA DEĞİŞİKLİĞİ"

let ulDOM = document.querySelector("ul#list")
let liDOM = document.createElement(`li`)

liDOM.innerHTML ="kendi yaptığımız sıra"
ulDOM.append(liDOM)