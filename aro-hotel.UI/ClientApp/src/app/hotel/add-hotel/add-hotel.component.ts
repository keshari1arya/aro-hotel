import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Store } from '@ngrx/store';
import { IHotel } from 'src/app/infrastructure/models/hotel';
import { IAddress } from 'src/app/infrastructure/models/IAddress';
import { IAppState } from 'src/app/state/app.index';
import * as AppActions from '../../state/app.actions';

@Component({
  selector: 'app-add-hotel',
  templateUrl: './add-hotel.component.html',
  styleUrls: ['./add-hotel.component.css']
})
export class AddHotelComponent implements OnInit {
  form: FormGroup;
  constructor(private formBuilder: FormBuilder, private appStore: Store<IAppState>,) { }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      name: ['', [Validators.required, Validators.minLength(3)]],
      description: ['', [Validators.required, Validators.minLength(3)]],
      phone: ['', [Validators.required]],
      line1: ['', [Validators.required]],
      line2: [''],
      city: ['', [Validators.required]],
      country: ['', [Validators.required]],
      state: ['', [Validators.required]],
      pincode: ['', [Validators.required]],
      landmark: [''],
      acknowledge: ['', [Validators.required]],
    });
  }
  onSubmit(): void {
    // this.submitted = true;

    // stop here if form is invalid
    if (this.form.invalid) {
      return;
    }
    let formValue = this.form.value;
    let hotel: IHotel = {
      name: formValue.name,
      description: formValue.description,
      phone: formValue.phone,
      address: {
        city: formValue.city,
        country: formValue.country,
        state: formValue.state,
        pincode: formValue.pincode,
        landMark: formValue.landmark,
        line1: formValue.line1,
        line2: formValue.line2
      }
    }

    this.appStore.dispatch(AppActions.CreateHotel({ hotel: hotel}));
    // display form values on success
    console.log(this.form.value);
  }
}
