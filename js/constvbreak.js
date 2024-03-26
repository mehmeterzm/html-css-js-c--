const LOREM_LIST = ["lorem", "dolor", "ipsum", "amet", "consectetur", "apipisicing", "elit"]

const ulDOM = document.querySelector("#userList")

let i = 0
// for(;i<LOREM_LIST.length;i++)
// {
//     if(LOREM_LIST[i] == "ipsum"){continue}
//     let liDOM= document.createElement('li')
//     liDOM.innerHTML = LOREM_LIST[i]
//     ulDOM.appendChild(liDOM)
    
// }
for(;i<LOREM_LIST.length;i++)
{
    if(LOREM_LIST[i] == "ipsum"){break}
    let liDOM= document.createElement('li')
    liDOM.innerHTML = LOREM_LIST[i]
    ulDOM.appendChild(liDOM)
    
}
