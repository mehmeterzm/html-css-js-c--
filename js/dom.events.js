let info = document.querySelector("#info")
info.addEventListener("click",domlistener)
function domlistener()
{
    console.log("tıklandı")
    console.log(this.innerHTML="tıklandığı için ismi değişti")
    console.log(this.style.color = "red")
}