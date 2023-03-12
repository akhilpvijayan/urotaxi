import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { AuthserviceService } from 'src/app/services/authservice.service';
import { User } from 'src/app/shared/user';
import { LoginComponent } from '../login.component';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.scss']
})
export class SignUpComponent implements OnInit {
  registerForm : User = new User;
  constructor(public dialog: MatDialog, private authService: AuthserviceService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm){
    form.form.value.isActive = true;
    this.authService.register(form.form.value).subscribe(
      (result) => {
        console.log(result);
      }
    )
  }
  
  login(){
    this.dialog.open(LoginComponent,{width:'790px', height:'460px', hasBackdrop:true, panelClass: 'custom-dialog-container' });
  }
}
