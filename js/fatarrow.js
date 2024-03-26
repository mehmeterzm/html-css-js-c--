function hello(firstName)
{
    console.log(`merhaba ${firstName}`)
}
hello("javascript")
const helloFuncV1 = (firstName) => {console.log(`merhaba ${firstName}`)}
helloFuncV1("HellofuncV1")

const helloFuncV2 = firstName => console.log(`merhaba ${firstName} `)
helloFuncV2("HellofuncV3")

const helloFuncV3 = (firstName, lastName) => console.log(`merhaba ${firstName} ${lastName}`)
helloFuncV3("HellofuncV3", "soyAd")

const helloFuncV4 = (firstName, lastName) =>{
let info = `Merhaba ${firstName} ${lastName}`
console.log(info)
return info
}
helloFuncV4("hellofuncv4","soyADD")