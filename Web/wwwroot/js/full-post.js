//function SimilarPostsViewModel() {
//    let self = this;
//    self.similarPosts = ko.observableArray([]);

//    self.getSimilarPosts = function () {
//        $.get('/home/loadsimilarposts?type=1', function (posts) {
//            for (let post of posts) {
//                let p = {
//                    title: post.title,
//                    url: '/home/post?url=' + post.url,
//                    image: 'https://storage.cloud.google.com/youit/' + post.url + '/thumbnail.png'
//                };
//                self.similarPosts.push(p);
//            }
//        });
//    };

//    self.getSimilarPosts();
//}



function MorePostsViewModel() {
    let self = this;
    self.morePosts = ko.observableArray([]);
    self.getMorePosts = function () {
        $.get('/home/loadsimilarposts?type=0', function (posts) {
            for (let post of posts) {
                let p = {
                    title: post.title,
                    url: '/home/post?url=' + post.url,
                    image: 'https://storage.cloud.google.com/youit/' + post.url + '/thumbnail.png'
                };
                self.morePosts.push(p);
            }
        });
    };

    self.getMorePosts();
}

//let similarPostsElem = document.getElementById("similar-posts");
let morePostsElem = document.getElementById("more-posts");

//console.log(similarPostsElem);
console.log(morePostsElem);

//ko.applyBindings(new SimilarPostsViewModel(), similarPostsElem);
ko.applyBindings(new MorePostsViewModel(), morePostsElem);