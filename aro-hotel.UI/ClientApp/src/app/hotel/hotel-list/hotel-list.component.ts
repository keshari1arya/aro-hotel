import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { Hotel } from 'src/app/infrastructure/models/hotel';
import { IAddress } from 'src/app/infrastructure/models/IAddress';
import { Multimedia } from 'src/app/infrastructure/models/Multimedia';
import { HotelService } from 'src/app/services/hotel.service';
import { IAppState } from 'src/app/state/app.index';
import * as AppActions from '../../state/app.actions';
import * as fromApp from '../../state/app.index';

@Component({
  selector: 'app-hotel-list',
  templateUrl: './hotel-list.component.html',
  styleUrls: ['./hotel-list.component.css'],
})
export class HotelListComponent implements OnInit {
  hotels?: Observable<Hotel[] | undefined> = new Observable();

  private notFoundImage = 'assets/not-found.jpeg';

  constructor(private appStore: Store<IAppState>) {}

  async ngOnInit(): Promise<void> {
    this.appStore.dispatch(AppActions.getHotels());
    this.hotels = this.appStore.pipe(select(fromApp.selectHotels));
  }

  getAddressString(address?: IAddress): string {
    return `${address?.line1}, ${address?.city}, ${address?.state}`;
  }

  getImage(hotel: Hotel): string {
      return hotel.multimedias[0]?.url ?? this.notFoundImage;
  }
}
