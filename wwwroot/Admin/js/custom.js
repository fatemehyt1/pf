$("[ImageInput]").change(function () {
    var x = $(this).attr("ImageInput");
    if (this.files && this.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $("[ImageFile=" + x + "]").attr('src', e.target.result);
        };
        reader.readAsDataURL(this.files[0]);
    }
});

function deleteCatalog(catalogId) {
    // url : /Admin/Catalogs/DeleteSlider/ + catalogId
    $.get('/Admin/Catalog/DeleteSlider/' + catalogId).then(res => {
        if(res.status === 'success'){
            $('#slider-item-' + catalogId).fadeOut();
        }
    });
}