let laptop1 = {
    brand: "Apple",
    model: "McBook Pro",
    "2kg": 2
}
console.log(laptop1)

console.log(laptop1.brand, laptop1["brand"])
console.log(laptop1["2kg"])

laptop1.brand = "Mac"
laptop1["brand"]="mac1"
console.log(laptop1)

laptop1.version = "10.15.7"
console.log(laptop1)

keys = object.keys(laptop1)
console.log(keys)
console.log(object.keys(laptop1))

keys.forEach(item => {
    console.log(item)
    console.log(laptop1[item])
});

console.log(
    object.values(laptop1)
    )
    let values = object.values(laptop1)
    values.forEach(value => {
        console.log("value: ",value)
    });