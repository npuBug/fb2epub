/*
 * DO NOT EDIT.  THIS FILE IS GENERATED FROM fb2epub_xpcom.idl
 */

#ifndef __gen_fb2epub_xpcom_h__
#define __gen_fb2epub_xpcom_h__


#ifndef __gen_nsISupports_h__
#include "nsISupports.h"
#endif

/* For IDL files that don't want to include root IDL files. */
#ifndef NS_NO_VTABLE
#define NS_NO_VTABLE
#endif

/* starting interface:    IFb2EpubConverter */
#define IFB2EPUBCONVERTER_IID_STR "3820526b-d2e7-44c4-9313-2f8cededde8e"

#define IFB2EPUBCONVERTER_IID \
  {0x3820526b, 0xd2e7, 0x44c4, \
    { 0x93, 0x13, 0x2f, 0x8c, 0xed, 0xed, 0xde, 0x8e }}

class NS_NO_VTABLE IFb2EpubConverter : public nsISupports {
 public: 

  NS_DECLARE_STATIC_IID_ACCESSOR(IFB2EPUBCONVERTER_IID)

  /* long Convert (in AString inputPath, in AString putputPath); */
  NS_IMETHOD Convert(const nsAString & inputPath, const nsAString & putputPath, int32_t *_retval) = 0;

};

  NS_DEFINE_STATIC_IID_ACCESSOR(IFb2EpubConverter, IFB2EPUBCONVERTER_IID)

/* Use this macro when declaring classes that implement this interface. */
#define NS_DECL_IFB2EPUBCONVERTER \
  NS_IMETHOD Convert(const nsAString & inputPath, const nsAString & putputPath, int32_t *_retval); 

/* Use this macro to declare functions that forward the behavior of this interface to another object. */
#define NS_FORWARD_IFB2EPUBCONVERTER(_to) \
  NS_IMETHOD Convert(const nsAString & inputPath, const nsAString & putputPath, int32_t *_retval) { return _to Convert(inputPath, putputPath, _retval); } 

/* Use this macro to declare functions that forward the behavior of this interface to another object in a safe way. */
#define NS_FORWARD_SAFE_IFB2EPUBCONVERTER(_to) \
  NS_IMETHOD Convert(const nsAString & inputPath, const nsAString & putputPath, int32_t *_retval) { return !_to ? NS_ERROR_NULL_POINTER : _to->Convert(inputPath, putputPath, _retval); } 

#if 0
/* Use the code below as a template for the implementation class for this interface. */

/* Header file */
class _MYCLASS_ : public IFb2EpubConverter
{
public:
  NS_DECL_ISUPPORTS
  NS_DECL_IFB2EPUBCONVERTER

  _MYCLASS_();

private:
  ~_MYCLASS_();

protected:
  /* additional members */
};

/* Implementation file */
NS_IMPL_ISUPPORTS1(_MYCLASS_, IFb2EpubConverter)

_MYCLASS_::_MYCLASS_()
{
  /* member initializers and constructor code */
}

_MYCLASS_::~_MYCLASS_()
{
  /* destructor code */
}

/* long Convert (in AString inputPath, in AString putputPath); */
NS_IMETHODIMP _MYCLASS_::Convert(const nsAString & inputPath, const nsAString & putputPath, int32_t *_retval)
{
    return NS_ERROR_NOT_IMPLEMENTED;
}

/* End of implementation class template. */
#endif


/* starting interface:    IFb2EpubConverterPaths */
#define IFB2EPUBCONVERTERPATHS_IID_STR "ff6e2a9f-08cc-4f2d-a38e-b6c74bab11c9"

#define IFB2EPUBCONVERTERPATHS_IID \
  {0xff6e2a9f, 0x08cc, 0x4f2d, \
    { 0xa3, 0x8e, 0xb6, 0xc7, 0x4b, 0xab, 0x11, 0xc9 }}

class NS_NO_VTABLE IFb2EpubConverterPaths : public nsISupports {
 public: 

  NS_DECLARE_STATIC_IID_ACCESSOR(IFB2EPUBCONVERTERPATHS_IID)

  /* long GetPathsCount (); */
  NS_IMETHOD GetPathsCount(int32_t *_retval) = 0;

  /* AString GetPath (in long iPath); */
  NS_IMETHOD GetPath(int32_t iPath, nsAString & _retval) = 0;

  /* AString GetPathName (in long iPath); */
  NS_IMETHOD GetPathName(int32_t iPath, nsAString & _retval) = 0;

};

  NS_DEFINE_STATIC_IID_ACCESSOR(IFb2EpubConverterPaths, IFB2EPUBCONVERTERPATHS_IID)

/* Use this macro when declaring classes that implement this interface. */
#define NS_DECL_IFB2EPUBCONVERTERPATHS \
  NS_IMETHOD GetPathsCount(int32_t *_retval); \
  NS_IMETHOD GetPath(int32_t iPath, nsAString & _retval); \
  NS_IMETHOD GetPathName(int32_t iPath, nsAString & _retval); 

/* Use this macro to declare functions that forward the behavior of this interface to another object. */
#define NS_FORWARD_IFB2EPUBCONVERTERPATHS(_to) \
  NS_IMETHOD GetPathsCount(int32_t *_retval) { return _to GetPathsCount(_retval); } \
  NS_IMETHOD GetPath(int32_t iPath, nsAString & _retval) { return _to GetPath(iPath, _retval); } \
  NS_IMETHOD GetPathName(int32_t iPath, nsAString & _retval) { return _to GetPathName(iPath, _retval); } 

/* Use this macro to declare functions that forward the behavior of this interface to another object in a safe way. */
#define NS_FORWARD_SAFE_IFB2EPUBCONVERTERPATHS(_to) \
  NS_IMETHOD GetPathsCount(int32_t *_retval) { return !_to ? NS_ERROR_NULL_POINTER : _to->GetPathsCount(_retval); } \
  NS_IMETHOD GetPath(int32_t iPath, nsAString & _retval) { return !_to ? NS_ERROR_NULL_POINTER : _to->GetPath(iPath, _retval); } \
  NS_IMETHOD GetPathName(int32_t iPath, nsAString & _retval) { return !_to ? NS_ERROR_NULL_POINTER : _to->GetPathName(iPath, _retval); } 

#if 0
/* Use the code below as a template for the implementation class for this interface. */

/* Header file */
class _MYCLASS_ : public IFb2EpubConverterPaths
{
public:
  NS_DECL_ISUPPORTS
  NS_DECL_IFB2EPUBCONVERTERPATHS

  _MYCLASS_();

private:
  ~_MYCLASS_();

protected:
  /* additional members */
};

/* Implementation file */
NS_IMPL_ISUPPORTS1(_MYCLASS_, IFb2EpubConverterPaths)

_MYCLASS_::_MYCLASS_()
{
  /* member initializers and constructor code */
}

_MYCLASS_::~_MYCLASS_()
{
  /* destructor code */
}

/* long GetPathsCount (); */
NS_IMETHODIMP _MYCLASS_::GetPathsCount(int32_t *_retval)
{
    return NS_ERROR_NOT_IMPLEMENTED;
}

/* AString GetPath (in long iPath); */
NS_IMETHODIMP _MYCLASS_::GetPath(int32_t iPath, nsAString & _retval)
{
    return NS_ERROR_NOT_IMPLEMENTED;
}

/* AString GetPathName (in long iPath); */
NS_IMETHODIMP _MYCLASS_::GetPathName(int32_t iPath, nsAString & _retval)
{
    return NS_ERROR_NOT_IMPLEMENTED;
}

/* End of implementation class template. */
#endif


#endif /* __gen_fb2epub_xpcom_h__ */
