const input = document.getElementById('name')
input.addEventListener('input', e=>{
    
})
const color = document.getElementById('color-picker')
color.addEventListener('input', e => {
 document.body.style.backgroundColor = e.target.value
 
})
const savebutton = document.getElementById('save-btn')
savebutton.addEventListener('click',e =>{
    console.log(
        input.value,
        color.value
    )
})
