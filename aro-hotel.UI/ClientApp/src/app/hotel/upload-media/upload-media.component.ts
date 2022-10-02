import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Store } from '@ngrx/store';
import { IAppState } from 'src/app/state/app.index';
import * as AppActions from '../../state/app.actions';

import { BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-upload-media',
  templateUrl: './upload-media.component.html',
  styleUrls: ['./upload-media.component.css']
})
export class UploadMediaComponent implements OnInit {
  id: string;
  form = this.fb.group({
    file: ['']
  })
  private currentId: string;

  private selectedFiles: File[] = [];
  constructor(private fb: FormBuilder, private appStore: Store<IAppState>, private modalService: BsModalService) { }


  ngOnInit(): void {
  }

  upload(): void {
    this.appStore.dispatch(AppActions.uploadImages({ file: this.selectedFiles, hotelId: this.id, roomId: '0' }));
    this.modalService.hide();
  }

  detectFiles($event: any) {
    console.log($event.target.files)
    let files = $event.target.files;
    for (let i = 0; i < files.length; i++) {
      this.selectedFiles.push(files[i]);
    }
  }
}
