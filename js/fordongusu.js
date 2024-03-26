let users = ["Lorem", "Ipsum", "Dolor"]

const userListDOM = document.querySelector('#userList')

for(i=0;i<users.length;i++)
{
    const liDOM = document.createElement('li')
    liDOM.innerHTML = users[i]
    userListDOM.appendChild(liDOM)
}