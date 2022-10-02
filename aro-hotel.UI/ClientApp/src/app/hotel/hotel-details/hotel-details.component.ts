import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { select, Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { IHotel } from 'src/app/infrastructure/models/hotel';
import { IMultimedia } from 'src/app/infrastructure/models/Multimedia';
import { IAppState } from 'src/app/state/app.index';
import * as AppActions from '../../state/app.actions';
import * as fromApp from '../../state/app.index';
import { BsModalService } from 'ngx-bootstrap/modal';
import { UploadMediaComponent } from '../upload-media/upload-media.component';

@Component({
  selector: 'app-hotel-details',
  templateUrl: './hotel-details.component.html',
  styleUrls: ['./hotel-details.component.css'],
})
export class HotelDetailsComponent implements OnInit {
  hotel$?: Observable<IHotel | undefined>;

  private notFoundImage = 'assets/not-found.jpeg';
  private currentId: string;

  constructor(private appStore: Store<IAppState>, private route: ActivatedRoute, private modalService: BsModalService) { }

  ngOnInit() {
    this.route.params.subscribe(params => {
      this.currentId = params['id'];
      this.appStore.dispatch(AppActions.getHotelDetails({ id: params.id }));
    });
    this.hotel$ = this.appStore.pipe(select(fromApp.selectHotelDetails));
  }

  getImage(image: IMultimedia): string {
    return image?.url ?? this.notFoundImage;
  }

  openModal(): void {
    this.modalService.show(UploadMediaComponent, { initialState: { id: this.currentId } });
  }
}
