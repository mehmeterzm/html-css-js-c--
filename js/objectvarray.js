let settings = {
    userName: "stop34",
    password: "8520zm",
    isActive: true,
    ip: "162.72.27",
    serverName: "kodluyoruz.org"
}
// let userName = settings.userName
// console.log(userName)

let {userName: user, password, isActive, ip, serverName} = settings

console.log(user, password, isActive, ip, serverName)
console.log(settings)
console.log(user)

//obje içinden bilgi çıkarma
let{userName: userName2, password: password2, ip: ip2, ...newSettings}= settings
console.log(userName2, password2, ip2, newSettings)

// objenin destructing ile kopyalanması
let settings2= {...settings}
settings2.userName= "deişen bilgi"
console.log("settings",settings)
console.log("settings2",settings2)

let score = [100,200,300,400]
let[score1, score2, ...otherScore]= score
//other score kısmı array objectin içinde liste oluşturduk
console.log(score1,sore2,otherScore)

let copyScore= [...score]
console.log(copyScore)

