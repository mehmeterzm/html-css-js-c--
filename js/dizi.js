let domain ="kodluyoruz"
let isActive = false
let items = [1, 2, 3, isActive, domain]
console.log(items)

console.log("[] :", Array.isArray( [] ))
console.log("1 :", Array.isArray( 1 ))
console.log("true :", Array.isArray( true ))
console.log(
    "ortadaki: ",
    items[Math.floor(items.length / 2)]
)