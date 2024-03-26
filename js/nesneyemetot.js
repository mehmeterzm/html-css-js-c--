let user1 = {
firstName: "Mehmet",
lastName : "Erdem",
score: [1, 2, 3, 4],
isActive: true,
shortName: function() { return `${this.firstName[0]}. ${this.lastName}`}
};
console.log(user1)