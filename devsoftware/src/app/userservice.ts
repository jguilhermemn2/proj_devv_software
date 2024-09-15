import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from './user';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private apiUrl = 'http://localhost:8899/api/User';  // URL da API


  constructor(private http: HttpClient) {}

  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    })
  };


  createUser(user: User): Observable<User> {
    alert("create")
    return this.http.post<User>(this.apiUrl, user, this.httpOptions);
  }

}
