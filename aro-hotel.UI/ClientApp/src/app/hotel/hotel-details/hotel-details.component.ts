import { Component, OnInit } from '@angular/core';
import { select, Store } from '@ngrx/store';

import { Observable } from 'rxjs';
import { Hotel } from 'src/app/infrastructure/models/hotel';
import { Multimedia } from 'src/app/infrastructure/models/Multimedia';
import { HotelService } from 'src/app/services/hotel.service';
import { IAppState } from 'src/app/state/app.index';
import * as AppActions from '../../state/app.actions';
import * as fromApp from '../../state/app.index';

@Component({
  selector: 'app-hotel-details',
  templateUrl: './hotel-details.component.html',
  styleUrls: ['./hotel-details.component.css'],
})
export class HotelDetailsComponent implements OnInit {
  hotel$?: Observable<Hotel | undefined>;

  constructor(private appStore: Store<IAppState>) {}

  ngOnInit(): void {
    this.appStore.dispatch(AppActions.getHotelDetails({ id: 1 }));
    this.hotel$ = this.appStore.pipe(select(fromApp.selectHotelDetails));
  }

  getImage(image: Multimedia): string {
    return image?.url ?? '';
  }
}
