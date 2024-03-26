const USERS = ["ZEHRA", "MehMet", "fIndILI", "CaGLAR"]
const NEW_USERS = USERS.map(user => user.toLowerCase())
console.log(NEW_USERS)
// returnla gönderme 
// const USERS_OBJ = USERS.map(item => 
//   {
// return{
//           userName: item, shortName: `${item[0]}.`, newName: `${item[0].toUpperCase()}${item.slice(1).toLowerCase()}`
//       }
//   }  
//     )
//object döndürme
const USERS_OBJ = USERS.map(item => 
    
            (
                {userName: item, shortName: `${item[0]}.`, newName: `${item[0].toUpperCase()}${item.slice(1).toLowerCase()}`}
                )
     
      )
    console.log(USERS_OBJ)