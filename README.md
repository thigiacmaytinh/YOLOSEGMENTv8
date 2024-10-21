# YOLOSEGMENTv8

Phần mềm kiểm thử độ chính xác Object Segmentation bằng YOLO v8. Chương trình chạy trên Windows 10 x64, chỉ sử dụng CPU (Không có CUDA).

Phiên bản CUDA: https://github.com/thigiacmaytinh/YOLOSEGMENTv8-CUDA

![](image/yolosegment2.jpg)

![](image/yolosegment.jpg)

## Chức năng

1. Segment object trong ảnh tĩnh

2. Segment object trong folder

3. Segment object trong webcam

4. Segment object trong video hoặc camera stream

5. Segment camera frame và bouding box
Dùng để retrain

## Hướng dẫn sử dụng

Các bạn cần cài đặt:

**C++ 2022 x64**: https://aka.ms/vs/17/release/vc_redist.x64.exe

**.NET framework 4.6.1**: https://dotnet.microsoft.com/en-us/download/dotnet-framework/net4612

## Cách convert file pt sang onnx

Sử dụng command sau, lưu ý bạn phải cài đặt YOLO v8 thành công

`!yolo export model='./best.pt' imgsz=640,640 format=onnx opset=12 simplify=True dynamic=False
`

## Bài viết hướng dẫn chi tiết
https://thigiacmaytinh.com/yololytic-phan-mem-phat-hien-vat-the-manh-me-va-de-su-dung/