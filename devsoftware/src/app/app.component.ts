import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { User } from './user';
import { FormsModule } from '@angular/forms';
import { bootstrapApplication } from '@angular/platform-browser';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  user: User = new User(1, '', '', '');
  submitted = false;


  onSubmit() {
    this.submitted = true;
    console.log('Usuário cadastrado:', this.user);
  }

  save(){

    alert(this.user.name);

  }

}
