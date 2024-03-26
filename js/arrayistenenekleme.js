const PRODUCTS = ["mic", "cable", "speaker", "desktop pc", "server", "mause", "keyboard"]

const NEW_PRODUCTS = PRODUCTS.filter(item => item.length > 5)
console.log(NEW_PRODUCTS)
const USERS = [
    {fulName: "Ayse Sumer", isActive: false},
    {fulName: "Ahmet Urgan", isActive: true},
    {fulName: "Asya Basar", isActive: true},
    {fulName: "Aksel Durmaz", isActive: false}
]
const ACTIVE_USERS = USERS.filter(user => user.isActive === true)
console.log(ACTIVE_USERS)