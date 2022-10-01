import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { select, Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { Hotel } from 'src/app/infrastructure/models/hotel';
import { Multimedia } from 'src/app/infrastructure/models/Multimedia';
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

  private notFoundImage = 'assets/not-found.jpeg';

  constructor(private appStore: Store<IAppState>, private route: ActivatedRoute,) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.appStore.dispatch(AppActions.getHotelDetails({ id: params.id }));
    });
    this.hotel$ = this.appStore.pipe(select(fromApp.selectHotelDetails));
  }

  getImage(image: Multimedia): string {
    return image?.url ?? this.notFoundImage;
  }
}
