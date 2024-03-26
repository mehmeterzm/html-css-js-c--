let items= [1, 2, 3, 4, 5]
let femaleUsers = ["Ayşe", "Hulya", "Merve"]
let maleUsers = ["Ahmet", "Ali", "Mehmet"]
items.unshift(femaleUsers)
items.push(maleUsers)
console.log(items)

let newItems= items.splice(1,5)

console.log("New Item: ",newItems )
console.log("Items: ",items)

items.unshift("Lorem")
items.push("Ipsum")

console.log(items.indexOf("Ipsum")) 

let copyItems= items
console.log(items)

//böyle kopyalanmaz
copyItems.pop()
console.log("copyItems", copyItems)
console.log("items", items)

//kopyalandıktan sonra
copyItems= items.slice()
console.log("copyItems", copyItems)
console.log("items", items)

//kopyalama
let allUsers= [...femaleUsers, ...maleUsers] //s6 le yapıldı sanırım araştır
console.log(allUsers)