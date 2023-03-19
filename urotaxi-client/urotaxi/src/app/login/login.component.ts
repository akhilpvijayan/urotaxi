import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { AuthserviceService } from '../services/authservice.service';
import { SignUpComponent } from './sign-up/sign-up.component';
import { Login } from '../shared/login';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
data = [];
loginForm : Login = new Login;
isLoggedIn: boolean = false;
loggedInDetails: any;
  constructor(public dialog: MatDialog, public authService : AuthserviceService, private dialogRef: MatDialogRef<LoginComponent>, private router: Router) { 
  }
  ngOnInit(): void {
  }

  onSubmit(form: NgForm){
    this.authService.login(form.form.value.Username, form.form.value.Password).subscribe(
      (result) => {
        console.log(result);
        this.isLoggedIn = result.token?true:false;
        this.loggedInDetails = result;
        localStorage.setItem('uroTaxi auth',result.token);
        this.authService.authData(result);
        this.closeLog();
        var route = this.router.url;
        if(route == '/home'){
          window.location.reload();
        }
      }
    )
  }

  closeLog(){    
    if(this.isLoggedIn){
      this.dialogRef.close();
  }}

  register(){
    this.dialog.open(SignUpComponent,{width:'920px', height:'507px', hasBackdrop:true, panelClass: 'custom-dialog-container' });
  }
}
