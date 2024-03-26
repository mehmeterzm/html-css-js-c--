let counter = 0
let counterDOM = document.querySelector("#counter")
let increaseDOM = document.querySelector(`#increase`)
let decreaseDOM = document.querySelector(`#decrease`)
counterDOM.innerHTML=counter
increaseDOM.addEventListener("click", eylem)
decreaseDOM.addEventListener("click", eylem)
function eylem(){
    console.log(this.id)
    this.id == "increase" ? counterDOM.innerHTML = counter += 1 :counterDOM.innerHTML = counter -= 1
 
}