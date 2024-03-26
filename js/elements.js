const ul = document.querySelector('ul')
const deleteButtons = document.querySelectorAll('.delete-btn')

deleteButtons.forEach(btn => {
    btn.addEventListener('click' , e => {
        e.target.remove()

    })
})
