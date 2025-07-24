import { Component, inject, OnInit } from '@angular/core';
import { Nav } from "../layout/nav/nav";
import { Router, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [Nav, RouterOutlet],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {
  protected router = inject(Router);

  async ngOnInit() {
    //this.setCurrentUser(); // Moved to InitService
  }

  // ------------------------ moved this code under init-service.ts ------------------------
  // setCurrentUser(){
  //   const userString = localStorage.getItem('user');
  //   if(!userString) return;
  //   const user = JSON.parse(userString);
  //   this.accountService.currentUser.set(user);
  // }
  
}
