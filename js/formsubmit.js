let formDOM= document.querySelector("#userForm")
formDOM.addEventListener(`submit`,formSubmit)

function formSubmit(event) {
    event.preventDefault()
    console.log("islem gerçekleşti")
    let scoreInputDOM = document.querySelector(`#score`)
    console.log(scoreInputDOM.value)
    localStorage.setItem(`score`,scoreInputDOM.value )
}