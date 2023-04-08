import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { UserService } from 'src/app/services/user.service';
import { User } from 'src/app/shared/user';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss']
})
export class AddUserComponent implements OnInit {
  userForm: User = new User;
  constructor(private dialogRef: MatDialogRef<AddUserComponent>,public userService: UserService) { }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    form.value.isActive = true;
    form.value.userId = 0;
    this.userService.addUser(form.value).subscribe(
      (result) => {
        this.resetForm(form);
        this.closeLog();
        window.location.reload();
      }
    )
  }

  closeLog() {
    this.dialogRef.close();
  }

  
  resetForm(form?: NgForm) {
    if (form != null) {
      form.reset();
    }
  }
}
