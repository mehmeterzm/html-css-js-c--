const PRODUCTS = ["Laptop", "phone", "speaker", "destkop pc", "server", "mause", "keyboard"]

// PRODUCT.forEach((product,index,array) => array[index]= product + " 111")
PRODUCTS.forEach((product,index,array) => array[index]= `${product.toUpperCase()}`)

console.log(PRODUCTS)

const userLİSTDOM = document.querySelector('#userList')
PRODUCTS.forEach(item => {
   const liDOM= document.createElement('li')
   liDOM.innerHTML= item 
   userLİSTDOM.append(liDOM)
})