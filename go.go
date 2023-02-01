package main

import (
	. "fmt"
)

type User struct {
	age    int
	height float32
	users  Users
}

type Users struct {
	playing_game string
}

func main() {
	cet := User{
		age:    18,
		height: 175.0,
		users: Users{
			playing_game: "ow",
		},
	}

	Println(cet.age, cet.height, cet.users.playing_game)
}
