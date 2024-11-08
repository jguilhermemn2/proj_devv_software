import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { User } from './user';
import { FormsModule } from '@angular/forms';
import { bootstrapApplication } from '@angular/platform-browser';
import { UserService } from './userservice';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, FormsModule, NgFor],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  user: User = new User('', '', '', '');
  x: User = new User('xsd', 'sds', 'rgt', 'weww');
  IsEdit: boolean = false;

  users: User[] = [this.x];
  submitted = false;

  constructor(private userService: UserService) { }
  ngOnInit(): void {
    this.loadData();
  }

  loadData(){
    this.userService.getAll().subscribe(data => {
      console.log(data);
      this.users = data;
    });
  }

  onSubmit() {
    this.submitted = true;
    console.log('Usuário cadastrado:', this.user);
  }

  save() {

    if (this.IsEdit) {

      this.userService.updateUser(this.user).subscribe(data => {
        console.log(data);
        this.IsEdit = false;
        this.clear()
      });

    } else {

      this.userService.createUser(this.user).subscribe(data => {
        console.log(data);
        this.IsEdit = false;
        this.clear()
      });

    }
  }

  edit(index: number) {
    this.IsEdit = true;
    this.user = this.users[index];
  }

  remove(id: any){

    this.userService.removeUser(id).subscribe(data => {
      console.log(data);
      this.loadData();
    });
  }

  clear() {
    this.IsEdit = false;
    this.user = new User('', '', '', '');
  }

}
