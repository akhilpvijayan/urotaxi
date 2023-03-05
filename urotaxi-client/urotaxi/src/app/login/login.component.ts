import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { AuthserviceService } from '../services/authservice.service';
import { SignUpComponent } from './sign-up/sign-up.component';
import { Login } from '../shared/login';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
data = [];
loginForm : Login = new Login;
  constructor(public dialog: MatDialog, public authService : AuthserviceService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm){
    this.authService.login(form);
  }

  register(){
    this.dialog.open(SignUpComponent,{width:'920px', height:'507px', hasBackdrop:true, panelClass: 'custom-dialog-container' });
  }
}
